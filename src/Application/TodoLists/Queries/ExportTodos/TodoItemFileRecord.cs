using New_folder.Application.Common.Mappings;
using New_folder.Domain.Entities;

namespace New_folder.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
