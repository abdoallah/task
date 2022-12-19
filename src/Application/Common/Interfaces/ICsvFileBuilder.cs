using New_folder.Application.TodoLists.Queries.ExportTodos;

namespace New_folder.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
