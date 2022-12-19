using System.Globalization;
using New_folder.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace New_folder.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
