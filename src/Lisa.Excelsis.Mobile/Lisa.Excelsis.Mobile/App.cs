﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Lisa.Excelsis.Mobile
{
    public class App : Application
    {
        public App()
        {
            
        }

        protected override void OnStart()
        {
            // make sure the tables are created before doing any database logic
            var db = DependencyService.Get<ISQLite>().GetConnection();

            db.CreateTable<Examdb>();
            db.CreateTable<Assessordb>();
            db.CreateTable<AssessmentAssessordb>();
            db.CreateTable<Assessmentdb>();
            db.CreateTable<Categorydb>();
            db.CreateTable<Criteriondb>();
            db.CreateTable<Observationdb>();
            db.CreateTable<Exam_Categorydb>();
            db.CreateTable<Markdb>();

            base.OnStart();

            Initialize.Exams();

            MainPage = new NavigationPage(new HistoryPage()){
               // BarBackgroundColor = Color.FromRgb(255, 165, 0), ORANGE
                BarBackgroundColor = Color.FromRgb(23, 96, 127),
                BarTextColor = Color.White
            };

        }
    }
}