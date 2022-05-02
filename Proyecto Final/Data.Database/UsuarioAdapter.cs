using Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Database
{
    public class UsuarioAdapter : Adapter
    {
        private readonly LavanderiaContext _context;
        // Este bypass es para poder usarlo desde el proyecto UI.Consola sin tener que crear el contexto
        public UsuarioAdapter() { }
        public UsuarioAdapter(LavanderiaContext context)
        {
            _context = context;
        }

        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                usuarios = _context.Usuarios
                    .Include(u => u.Empleado)
                    .ToList();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar listado de usuarios", e);
                throw ExceptionManejada;
            }
            return usuarios;
        }

        public Business.Entities.Usuario GetOne(int ID)
        {
            try
            {
                return _context.Usuarios.Include(u => u.Empleado).FirstOrDefault(u => u.IdUsuario == ID);
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al recuperar datos de usuario", e);
                throw ExceptionManejada;
            }
            return null;
        }

        protected void Update(Usuario usuario)
        {
            try
            {
                _context.Usuarios.Update(usuario);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al modificar datos del usuario", e);
                throw ExceptionManejada;
            }
        }
        protected void Insert(Usuario usuario)
        {
            try
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al crear cliente", e);
                throw ExceptionManejada;
            }
        }
        public void Delete(int ID)
        {
           
        }

        public void Save(Usuario usuario)
        {
            if (usuario.State == BusinessEntity.States.New)
            {
                this.Insert(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Deleted)
            {
                this.Delete(usuario.IdUsuario);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
                this.Update(usuario);
            }
            usuario.State = BusinessEntity.States.Unmodified;
        }
        public Usuario Login(string usuario, string contrasenia)
        {
            try
            {
                Usuario usr = _context.Usuarios.Include(u => u.Empleado).FirstOrDefault(u => u.NombreUsuario == usuario);
                if (usr == null) return null;
                //contrasenia = new Hasher().GenerateHash(contrasenia, usr.Salt);
                if (usr.Clave != contrasenia) return null;
                return usr;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar usuario", Ex);
                throw ExcepcionManejada;
            }
        }
    }
}
