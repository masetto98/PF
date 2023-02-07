using Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography;

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
            
            Usuario userAnterior = GetOne(usuario.IdUsuario);
            if (usuario.Clave != null && usuario.Clave != userAnterior.Clave)
            {
                userAnterior.Clave = new Hasher().GenerateHash(usuario.Clave, userAnterior.Salt);
            }
            else
            {
                userAnterior.Clave = usuario.Clave;
            }
            if (usuario.Respuesta != null && usuario.Respuesta != userAnterior.Respuesta)
            {
                userAnterior.Respuesta = new Hasher().GenerateHash(usuario.Respuesta, userAnterior.Salt);
            }
            else { userAnterior.Respuesta = usuario.Respuesta; }
            try
            {
                _context.Usuarios.Update(userAnterior);
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
            usuario.Salt = new Hasher().GenerateSalt();
            usuario.Clave = new Hasher().GenerateHash(usuario.Clave, usuario.Salt);
            usuario.Respuesta = new Hasher().GenerateHash(usuario.Respuesta, usuario.Salt);
            try
            {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            }
            catch (Exception e)
            {
            Exception ExceptionManejada = new Exception("Error al crear usuario", e);
            throw ExceptionManejada;
            }
        }
        public void Delete(int ID)
        {
            Usuario usuario = new Usuario();
            try
            {
                usuario = _context.Usuarios.Find(ID);
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar usuario", e);
                throw ExceptionManejada;
            }
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
                contrasenia = new Hasher().GenerateHash(contrasenia, usr.Salt);
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
