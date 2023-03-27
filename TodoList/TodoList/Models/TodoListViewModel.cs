using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using TodoList.Models;
using Dapper;
using TodoList.Helpers;

namespace TodoList.ViewModels
{
    public class TodoListViewModel
    {
        public TodoListViewModel()
        {
            using (var db = DbHelper.GetConnection())
            {
                EditableItem = new TodoListItem();
                TodoItems = db.Query<TodoListItem>("SELECT * FROM [TodoList].[dbo].[TodoListItems] ORDER BY AddDate DESC").ToList();
            }
        }

        public List<TodoListItem> TodoItems { get; set; }

        public TodoListItem EditableItem { get; set; }
    }
}