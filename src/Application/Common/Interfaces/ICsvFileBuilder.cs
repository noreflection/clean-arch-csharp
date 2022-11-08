using clean_arch.Application.TodoLists.Queries.ExportTodos;

namespace clean_arch.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
