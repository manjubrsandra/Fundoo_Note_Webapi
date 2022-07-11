﻿using BusinessLayer.Interfaces;
using DatabaseLayer.Label;
using RepositoryLayer.Interfaces;
using RepositoryLayer.Services.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class LabelBL : ILabelBL
    {
        ILabelRL labelRL;
        public LabelBL(ILabelRL labelRL)
        {
            this.labelRL = labelRL;
        }

        public async Task AddLabel(int userId,int noteId,string labelName)
        {
            try
            {
                await this.labelRL.AddLabel(userId, noteId,labelName);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task DeleteLabel(int userId, int noteId)
        {
            try
            {
                await this.labelRL.DeleteLabel(userId, noteId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<LabelResponseModel>> GetAllLabelsByLinqJoins(int UserId)
        {
            try
            {
                return await this.labelRL.GetAllLabelsByLinqJoins(UserId);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public async Task<Label> GetLabel(int userId, int noteId)
        {
            try
            {
                return await this.labelRL.GetLabel(userId, noteId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task UpdateLabel(int userId, int noteId, string labelName)
        {
            try
            {
                await this.labelRL.UpdateLabel(userId, noteId, labelName);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
    
}
