﻿using DatabaseLayer.Note;
using DatabaseLayer.User;
using RepositoryLayer.Services.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface INoteRL
    {
        Task AddNote(int UserId, NotePostModel notePostModel);
        Task<List<Note>> GetAllNote(int UserId);

        Task DeleteNote(int UserId, int noteId);
        Task UpdateNote(int UserId,int noteId, NoteUpdateModel noteUpdateModel);

        Task RemainderNote(int UserId, int noteId);
        Task PinNote(int UserId, int noteId);

        Task ArchiveNote(int UserId, int noteId);
    }
}
