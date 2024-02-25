﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OnlineExamination.Entities;

[PrimaryKey("StudentId", "QuestionId")]
[Table("Student_Answer_In_Exam")]
public partial class StudentAnswerInExam
{
    [Key]
    [Column("Student_Id")]
    public int StudentId { get; set; }

    [Column("Exam_Id")]
    public int ExamId { get; set; }

    [Key]
    [Column("Question_Id")]
    public int QuestionId { get; set; }

    [Required]
    [Column("Student_Answer")]
    [StringLength(200)]
    [Unicode(false)]
    public string StudentAnswer { get; set; }

    [ForeignKey("ExamId")]
    [InverseProperty("StudentAnswerInExams")]
    public virtual Exam Exam { get; set; }

    [ForeignKey("QuestionId")]
    [InverseProperty("StudentAnswerInExams")]
    public virtual Question Question { get; set; }

    [ForeignKey("StudentId")]
    [InverseProperty("StudentAnswerInExams")]
    public virtual Student Student { get; set; }
}