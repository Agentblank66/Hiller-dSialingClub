﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSialingClub
{
    public class ActivityList
    {
        List<Activity> List = new List<Activity>();

        //Method which adds an activity to the List.
        public void AddActivity(Activity activity)
        {
            List.Add(activity);
        }

        //Method which deletes an activtity from the list.
        public void DeleteActivity(Activity activity)
        {
            List.Remove(activity);
        }

        //Method which finds a specific activity, by searching for an activitys Id in the list and then returns that activity.  
        public Activity? GetActivity(int id) 
        {
            foreach (var activity in List) 
            {
                if (activity.Id == id) 
                    return activity;
            }
            return null;
        }

        //Method which updates an activity, by using the GetActivity method to find a specific activity and then changing that activitys parameters.
        public void UpdateActivity(Activity activity, string name, string description, int year, int month, int day) 
        {
            var theActivity = GetActivity(activity.Id);
            if (theActivity != null) 
            {
                theActivity.Name = name;
                theActivity.Description = description;
                theActivity.Date = new DateTime(year, month, day);
            }
        }

        //Method which goes through the old list(List) by searching for either a name or a description and is than added to the new empty list(activities) of all the activities, either with big or small lette.
        public List<Activity> SearchActivity(string keyWord)         
        {
            List<Activity> activities = new List<Activity>();
            foreach (Activity activity in List) 
            {
                if (activity.Name.ToLower().Contains(keyWord.ToLower()) || activity.Description.ToLower().Contains(keyWord.ToLower()))
                {
                    activities.Add(activity);
                } 
            }
            return activities;
        }


        //Method which prints out every activity.
        public void ListPrint()
        {
            foreach(var activity in List)
            {
                Console.WriteLine(activity);
            }
        }
    }
}
