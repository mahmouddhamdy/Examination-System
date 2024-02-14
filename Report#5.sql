CREATE PROC questionsAndChoicesFromExamID @ExamID int
AS 
Select distinct Questions.Content, Choices.Choice_Number, Choices.Content
From Exams, Exam_Questions, Questions, Choices
Where @ExamID = Exam_Questions.Exam_ID AND Exam_Questions.Question_Id = Questions.Question_Id 
AND Questions.Question_Id = Choices.Question_Id