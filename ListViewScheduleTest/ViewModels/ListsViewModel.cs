using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ListViewScheduleTest.Models;
using Xamarin.Forms;

namespace ListViewScheduleTest.ViewModels
{
    public class ListsViewModel: BaseViewModel
    {
        public ObservableCollection<ItemsList> Groups { get; } = new ObservableCollection<ItemsList>();

        public ICommand ShowStudents { get; set; }

        public string counter = "22";

        public string Counter
        {
            get => counter;
            set => SetProperty(ref counter, value);
        }


        public ListsViewModel()
        {
            PrepareData();
            ShowStudents = new Command(PrepareData);
        }

        private void PrepareData()
        {
            var counterInt = 2;
            if (int.TryParse(counter, out int result))
            {
                counterInt = result;
            }

            var list1 = new List<Item>();
            var list2 = new List<Item>();
            for (int i = 0; i < counterInt; i++)
            {
                if (i % 2 == 0)
                {
                    list2.Add(new Item
                    {
                        Description = $"Student {i}",
                        Id = i.ToString(),
                        Text = $"{DateTime.Today.AddHours(i):HH:mm}"

                    });
                }
                else
                {
                    list1.Add(new Item
                    {
                        Description = $"Student {i}",
                        Id = i.ToString(),
                        Text = $"{DateTime.Today.AddHours(i):HH:mm}"

                    });
                }


            }

            //if (Groups.Any())
            //{
            Groups.Clear();
            ////}
            var a1 = new ItemsList("Uneven students", "Students with Uneven ids",list1);
            Groups.Add(a1);
            Groups.Add(new ItemsList ("Even students", "Students with even ids", list2));
            Groups.Add(a1);
        }
    }
}
