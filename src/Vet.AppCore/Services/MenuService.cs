using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Vet.AppCore.Entity;
using Vet.AppCore.Interfaces.Repository;
using Vet.AppCore.Interfaces.Services;

namespace Vet.AppCore.Services
{
    public class MenuService : IService<Menu>, IMenuService
    {
        private readonly IMenuRepository _app;
        public MenuService(IMenuRepository app)
        {
            _app = app;
        }

        public Menu Adicionar(Menu entity)
        {
            return _app.Adicionar(entity);
        }

        public Menu Atualizar(Menu entity)
        {
            return _app.Atualizar(entity);
        }

        public IEnumerable<Menu> Buscar(Expression<Func<Menu, bool>> expression)
        {
            return _app.Buscar(expression);
        }

        public Menu Get(int id)
        {
            return _app.Get(id);
        }

        public IEnumerable<Menu> GetAll()
        {
            return _app.GetAll();
        }

        public string Remover(Menu entity)
        {
            return _app.Remover(entity);
        }
    }
}
