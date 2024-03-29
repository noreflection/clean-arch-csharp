﻿using System.Globalization;
using clean_arch.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace clean_arch.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
