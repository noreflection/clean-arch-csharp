﻿using FluentValidation;

namespace clean_arch.Application.TodoItems.Commands.CreateTodoItem;

public class CreateTodoItemCommandValidator : AbstractValidator<CreateTodoItemCommand>
{
    public CreateTodoItemCommandValidator()
        => RuleFor(v => v.Title)
            .MaximumLength(200)
            .NotEmpty();
}