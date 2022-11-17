// See https://aka.ms/new-console-template for more information
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System.Security.Principal;
using tray.first.Interface;
using tray.first.Repositories;
using tray.mok;

Console.WriteLine("Hello, World!");
IContext mock = new MockContext();
IRoleRepository role1 = new RoleRepository(mock);
role1.GetAll();
