using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Extensions.DependencyInjection;

namespace POSWinFormLayer;

public interface IFormFactory
{
    T Create<T>() where T : Form;
}

public class FormFactory : IFormFactory
{
    private readonly IServiceProvider _serviceProvider;

    public FormFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public T Create<T>() where T : Form
    {
        // Resolve the form from the DI container
        return _serviceProvider.GetRequiredService<T>();
    }
}