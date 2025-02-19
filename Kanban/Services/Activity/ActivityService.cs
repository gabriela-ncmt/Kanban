﻿using Kanban.Data;
using Kanban.Dto;
using Kanban.Models;
using Microsoft.EntityFrameworkCore;

namespace Kanban.Services.Activity
{
    public class ActivityService : IActivityInterface
    {
        private readonly AppDbContext _context;
        public ActivityService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<ActivityModel>> GetActivitiesAsync()
        {
            try
            {
                var activities = await _context.Activities.Include(x => x.Status).ToListAsync();
                return activities;
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<StatusModel>> GetStatuses()
        {
            try
            {
                var status = await _context.Status.ToListAsync();
                return status;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ActivityModel> AddActivity(AddActivityDto addActivityDto)
        {
            try
            {
                Random rand = new Random();

                //mapping activitydto to activitymodel
                var activity = new ActivityModel()
                {
                    Title = addActivityDto.Title,
                    Description = addActivityDto.Description,
                    StatusId = addActivityDto.StatusId,
                    Enrollment = rand.Next(1000, 100000)
                };

                _context.Activities.Add(activity);
                await _context.SaveChangesAsync();

                return activity;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ActivityModel> ChangeCard(int activityId)
        {
            try
            {
                var activity = await _context.Activities.FindAsync(activityId);
                activity.StatusId++;

                _context.Update(activity);
                await _context.SaveChangesAsync();
                return activity;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ActivityModel> Delete(int activityId)
        {
            try
            {
                var activity = await _context.Activities.FindAsync(activityId);
                _context.Remove(activity);
                await _context.SaveChangesAsync();
                return activity;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ActivityModel> ChangePreviousCard(int activityId)
        {
            try
            {
                var activity = await _context.Activities.FindAsync(activityId);
                activity.StatusId--;

                _context.Update(activity);
                await _context.SaveChangesAsync();
                return activity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
