﻿using ExamSystem_Project.ApiRequestors;
using ExamSystem_Project.Forms;
using ExamSystem_Project.Helpers;
using ExamSystem_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem_Project.FormModels
{

    public class TeacherFormModel
    {
        public Exam exam;
        public List<Exam> exams;
        public TeacherForm teacher;
        public General gen = new General();
        public static TeacherFormModel teacherFormModel;
        public DataTable dataTable;
        Dictionary<string, int> filterdTags;
        BuildExamForm buildExam;
        public TeacherFormModel(TeacherForm teacherForm)
        {
            exam = new Exam();
            exams = new List<Exam>();
            this.teacher = teacherForm;
            teacherFormModel = this;
            filterdTags = new Dictionary<string, int>();
            GetAllExams();

        }
        public async void GetAllExams()
        {
            try
            {
                exams = await General.mainRequestor.Request_GetAll<Exam>("api/exams/getallexams");

                if (exams.Count > 0)
                {

                    teacher.dataGridView_teacherExams.DataSource = exams;
                    for (int i = 0; i < exams.Count; i++)
                    {
                        var res = await General.mainRequestor.Request_GetById<Participation?>(exams[i].ExamId.ToString(), "api/participations");
                        if (res.Student_Id != null)
                        {
                            teacher.dataGridView_teacherExams.DataSource = exams;
                            teacher.dataGridView_teacherExams.Rows[i].Cells[9] = new DataGridViewTextBoxCell();
                            teacher.dataGridView_teacherExams.Rows[i].Cells[9].Tag = 1;
                            teacher.dataGridView_teacherExams.Rows[i].Cells[9].Value = "Executed";

                        }
                        else
                        {
                            teacher.dataGridView_teacherExams.DataSource = exams;
                            teacher.dataGridView_teacherExams.Rows[i].Cells[9].Tag = 0;
                        }

                    }
                }
            }
            catch (Exception ex)
            {


            }
        }



        private void SaveCellTags()
        {
            try
            {
                foreach (DataGridViewRow row in teacher.dataGridView_teacherExams.Rows)
                {
                    DataGridViewCell cell9 = row.Cells[9];
                    DataGridViewCell cell0 = row.Cells[0];
                    if (!filterdTags.ContainsKey(cell0.Value.ToString()))
                    {
                        filterdTags.Add(cell0.Value.ToString(), int.Parse(cell9.Tag.ToString()));
                    }
                    else
                    {
                        filterdTags[cell0.Value.ToString()] = int.Parse(cell9.Tag.ToString());
                    }
                }
            }
            catch (Exception ex)
            {


            }

        }




        private void RestoreCellTags()
        {
            try
            {
                if (teacher.dataGridView_teacherExams.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in teacher.dataGridView_teacherExams.Rows)
                    {
                        DataGridViewCell cell9 = row.Cells[9];
                        DataGridViewCell cell0 = row.Cells[0];
                        if (filterdTags.ContainsKey(cell0.Value.ToString()))
                        {
                            cell9.Tag = filterdTags[cell0.Value.ToString()];
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }


        }

        public void FilterRows(string filterValue)
        {
            try
            {

                if (exams.Count > 0)
                {

                    SaveCellTags();
                    List<Exam> filteredList = exams
                         .Where(item => item.ExamTitle.ToLower().Contains(filterValue))
                         .ToList();
                    teacher.dataGridView_teacherExams.DataSource = null;
                    teacher.dataGridView_teacherExams.DataSource = filteredList;
                    RestoreCellTags();


                    if (teacher.dataGridView_teacherExams.Rows.Count > 0)
                    {
                        for (int i = 0; i < teacher.dataGridView_teacherExams.Rows.Count; i++)
                        {

                            var x = teacher.dataGridView_teacherExams.Rows[i].Cells[9].Tag;
                            if ((int)x == 1)
                            {
                                teacher.dataGridView_teacherExams.Rows[i].Cells[9] = new DataGridViewTextBoxCell();
                                teacher.dataGridView_teacherExams.Rows[i].Cells[9].Tag = 1;
                                teacher.dataGridView_teacherExams.Rows[i].Cells[9].Value = "Executed";
                            }
                        }
                    }

                }

            }
            catch (Exception ex)
            {


            }



        }

        //public void FilterRows(string filterValue)
        //{
        //    try
        //    {
        //        if (exams.Count > 0)
        //        {
        //            List<Exam> filteredList = exams
        //                 .Where(item => item.ExamTitle.ToLower().Contains(filterValue))
        //                 .ToList();
        //            teacher.dataGridView_teacherExams.DataSource = null;
        //            teacher.dataGridView_teacherExams.DataSource = filteredList;
        //        }
        //    }
        //    catch (Exception ex)
        //    {


        //    }



        //}

        public void OpenExistExam(User user)
        {
            try
            {
                int index = teacher.dataGridView_teacherExams.SelectedRows[0].Index;
                exam = exams[index];
                buildExam = new BuildExamForm(exam, user);
                buildExam.ShowDialog();

            }
            catch (Exception ex)
            {


            }


        }

        public void CreateNewExam(User user)
        {
            buildExam = new BuildExamForm(null, user);
            buildExam.ShowDialog();
        }

    }
}
