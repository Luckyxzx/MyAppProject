using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MyAppProject.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.IO;
using MyAppProject.Data;
using MyAppProject.Helpers;

namespace MyAppProject.Views
{
    public partial class Forum : ContentPage
    {
        private readonly DBHelper dbHelper;

        public Forum()
        {
            InitializeComponent();
            dbHelper = new DBHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyDatabase.db3"));
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            TopicsListView.ItemsSource = await dbHelper.GetAllTopicsAsync();
        }

        private async void OnTopClicked(object sender, EventArgs e)
        {
            Topic topic = new Topic
            {
                Title = TitleEntry.Text,
                Creator = CreatorEntry.Text,
                Message = MessageEditor.Text
            };
            await dbHelper.SaveTopicAsync(topic);
            TopicsListView.ItemsSource = await dbHelper.GetAllTopicsAsync();
        }


        private async void OnDeleteTopicClicked(object sender, EventArgs e)
        {
            Topic topic = ((MenuItem)sender).CommandParameter as Topic;
            await dbHelper.DeleteTopicAsync(topic);
            TopicsListView.ItemsSource = await dbHelper.GetAllTopicsAsync();
        }
    }

}
