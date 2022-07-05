﻿using BusinessLayer.Interfaces;
using DatabaseLayer.Note;
using DatabaseLayer.User;
using RepositoryLayer.Interfaces;
using RepositoryLayer.Services.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class NoteBL : INoteBL
    {
        INoteRL noteRL;

        public NoteBL(INoteRL noteRL)
        {
            this.noteRL = noteRL;
        }
     
        public async Task AddNote(int UserId, NotePostModel notePostModel)
        {
            try
            {
                await this.noteRL.AddNote(UserId, notePostModel);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public async Task ArchiveNote(int UserId, int noteId)
        {
            try
            {
                await this.noteRL.ArchiveNote(UserId, noteId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task DeleteNote(int UserId, int NoteId)
        {
            try
            {
                await this.noteRL.DeleteNote(UserId, NoteId);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public async Task<List<Note>> GetAllNote(int UserId)
        {
            try
            {
                return await this.noteRL.GetAllNote(UserId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task PinNote(int UserId, int noteId)
        {
            try
            {
                await this.noteRL.PinNote(UserId, noteId);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async  Task RemainderNote(int UserId, int noteId)
        {
           
            
                try
                {
                    await this.noteRL.RemainderNote(UserId, noteId);
                }
                catch (Exception e)
                {
                    throw e;
                }

        }

        public async Task UpdateNote(int UserId, int NoteId, NoteUpdateModel noteUpdateModel)
        {
            try
            {
                await this.noteRL.UpdateNote(UserId, NoteId, noteUpdateModel);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
    

