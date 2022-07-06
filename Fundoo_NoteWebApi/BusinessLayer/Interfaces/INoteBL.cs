﻿using DatabaseLayer.Note;
using DatabaseLayer.User;
using RepositoryLayer.Services.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface INoteBL
    {
        Task AddNote( int UserId,NotePostModel notePostModel);
        Task<List<Note>> GetAllNote(int UserId);
        Task DeleteNote(int UserId, int noteId);
        Task UpdateNote(int UserId, int NoteId, NoteUpdateModel noteUpdateModel);

        Task ReminderNote(int UserId, int noteId, DateTime dateTime);
        Task PinNote(int UserId, int noteId);

        Task ArchiveNote(int UserId, int noteId);

        Task ChangeColour(int UserId, int noteId, string Colour);





    }
}
