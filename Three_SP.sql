--Exam Generation

Delete from Student_Answer_In_Exam
Delete From Exam_Questions
DBCC CHECKIDENT('Exams', RESEED, 0);


alter proc Exam_Generation @Crs_Name varchar(10), @num_MCQ int ,@num_ToF int
as
	if not exists(select c.Course_Name from Courses c where c.Course_Name = @Crs_Name) 
	begin
		RAISERROR('Invalid Course Name', 16, 1);
		return;
	end
	if @num_MCQ + @num_ToF = 10
	BEGIN
		DECLARE @crsID int
		Select @crsID = Courses.Course_Id From Courses where Courses.Course_Name = @Crs_Name

		DECLARE @LastExam int
		Select @LastExam =
			Count(Exams.Exam_Id) 
			From Exams
			Group By Course_ID
			Having Course_Id = @crsID


		declare @ExamName varchar(50) =concat(@Crs_Name + ' ',(ISNULL (@LastExam,0) + 1))
		exec InsertExam @ExamName,'2 Hours',@crsID;

		DECLARE @ExmId INT
		SET @ExmId = ISNULL((select top(1) Exam_Id from Exams order by Exam_Id DESC),1)


		insert into Exam_Questions
		select top(@num_MCQ) q.Question_Id , @ExmId  from Questions q ,Courses c
		where q.Question_Type = 'MCQ' and c.Course_Id = q.Course_Id and c.Course_Name = @Crs_Name   
		order by NEWID()

		insert into Exam_Questions
		select top(@num_ToF) q.Question_Id , @ExmId  from Questions q ,Courses c
		where q.Question_Type = 'T/F' and c.Course_Id = q.Course_Id and c.Course_Name = @Crs_Name   
		order by NEWID()
	End

	else
		RAISERROR('Invalid Parameter', 16, 1);
 

 Exam_Generation 'Database' , 5 , 5

------------------------------------------------------------------------

--Exam-Answers 
alter proc Exam_Answers @exam_id int /* 2 */ , @std_Id int /*1 */ , @Ans_1 varchar(50),@Ans_2 varchar(50) 
					,@Ans_3 varchar(50),@Ans_4 varchar(50),@Ans_5 varchar(50),@Ans_6 varchar(50),
					@Ans_7 varchar(50),@Ans_8 varchar(50),@Ans_9 varchar(50),@Ans_10 varchar(50)
as
	if not exists(select Exams.Exam_Id From  Exams  where Exams.Exam_Id = @exam_id) 
	begin
		RAISERROR('Invalid Exam ID', 16, 1);
		return;
	end


	if not exists(select Students.Student_Id From  Students  where Students.Student_Id = @std_Id) 
	begin
		RAISERROR('Invalid Student ID', 16, 1);
		return;
	end

	Declare @CourseID int;
	Select @CourseID = Exams.Course_Id From Exams where Exams.Exam_Id = @exam_id

	if exists (
		Select Student_Courses.Student_Id 
		From Student_Courses
		Where Student_Id= @std_Id and Course_Id = @CourseID and StudentGrade IS NOT NULL)
	
		begin

			RAISERROR('Student Has already took this exam!', 16, 1);
			return;
		end

	declare @indx int =0 , @Quest_id int
	while @indx <10
	begin
		set @indx +=1
		select @Quest_id=Question_Id from(
			select * , ROW_NUMBER() over (partition by Exam_ID order by Question_Id) as RN
			from Exam_Questions
			where Exam_ID = @exam_id
		) as Newtable Where RN =@indx   
			
				declare @Answer varchar(50) = CASE @indx
				WHEN 1 THEN @Ans_1
				WHEN 2 THEN @Ans_2
				WHEN 3 THEN @Ans_3
				WHEN 4 THEN @Ans_4
				WHEN 5 THEN @Ans_5
				WHEN 6 THEN @Ans_6
				WHEN 7 THEN @Ans_7
				WHEN 8 THEN @Ans_8
				WHEN 9 THEN @Ans_9
				WHEN 10 THEN @Ans_10
			END

		exec InsertStudentAnswerOfQuestionInExam @std_Id,@Quest_id,@exam_id,@Answer 

	end



Exam_Answers 3,1,'d','b','a','b','a','a','b','a','a','b' 


------------------------------------------------------------------------

--Exam-Correct 


ALTER PROC Exam_Correct @ExamID int, @StudentID int
AS

	if not exists(select Exams.Exam_Id From  Exams  where Exams.Exam_Id = @ExamID) 
	begin
		RAISERROR('Invalid Exam ID', 16, 1);
		return;
	end


	if not exists(select Students.Student_Id From  Students  where Students.Student_Id = @StudentID) 
	begin
		RAISERROR('Invalid Student ID', 16, 1);
		return;
	end


	Declare @StudentGrade decimal(18,2) = 0;
	Declare @totalGrade int = 0;
	
	DECLARE @SavedResult TABLE (
		Question_Id INT,
		Student_Answer VARCHAR(255),
		Answer_Value VARCHAR(255),
		Grade INT
	);


	INSERT INTO @SavedResult (Question_Id, Student_Answer, Answer_Value, Grade)
	SELECT Student_Answer_In_Exam.Question_Id, Student_Answer_In_Exam.Student_Answer, Answers.Value, Questions.Grade
	FROM Student_Answer_In_Exam, Questions, Answers
	WHERE Student_Answer_In_Exam.Question_Id = Questions.Question_Id 
		AND Answers.Question_Id = Questions.Question_Id
		AND Student_Id = @StudentID
		AND Exam_Id = @ExamID;

	Declare @tableRows int;
	Select @tableRows = count(*) From @SavedResult;

	if ( @tableRows = 0 ) 
		begin
			RAISERROR('This student did not take this exam!', 16, 1);
			return;
		end
		

	DECLARE @Student_Answer VARCHAR(255);
	DECLARE @Answer_Value VARCHAR(255);
	DECLARE @Grade INT;

	DECLARE cursor_saved_result CURSOR FOR

	SELECT Student_Answer, Answer_Value, Grade
	FROM @SavedResult;
	OPEN cursor_saved_result;
	FETCH NEXT FROM cursor_saved_result INTO  @Student_Answer, @Answer_Value, @Grade;
	WHILE @@FETCH_STATUS = 0
	BEGIN
		set @totalGrade += @Grade;
		if (@Student_Answer = @Answer_Value)
				Set @StudentGrade += @Grade;
		FETCH cursor_saved_result INTO  @Student_Answer, @Answer_Value, @Grade;
	END
	CLOSE cursor_saved_result;
	DEALLOCATE cursor_saved_result;

	set @StudentGrade = (@StudentGrade / @totalGrade) * 100;

	Declare @CourseID int;
	Select @CourseID = Exams.Course_Id 
						From Exams
						Where Exams.Exam_Id = @ExamID

	exec InsertStudentCourse @StudentID, @CourseID, @StudentGrade


Exam_Correct 2,1