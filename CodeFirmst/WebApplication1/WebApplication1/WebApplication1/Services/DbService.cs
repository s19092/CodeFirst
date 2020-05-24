﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class DbService : IDbService
    {

        ClinDbContext _context;

        public DbService(ClinDbContext c)
        {
            _context = c;
        }
        
        public string AddDoctor(Doctor doctor)
        {

            try
            {
                _context.Doctors.Add(doctor);
                return "Ok";
            }
            catch(Exception e)
            {

                return "Error";

            }
        }

        public Doctor GetDoctor(int id)
        {

            try
            {
                return _context.Doctors.First(d => d.Id == id);
            }catch(Exception e)
            {
                return null;
            }
        }

        public string RemoveDoctor(int id)
        {
            try
            {
                var st = _context.Doctors.First(d => d.Id == id);
                if (st != null)
                    _context.Doctors.Remove(st);
                return "Ok";
            
            }catch(Exception e)
            {

                return "ERror";
              
            }
        }

        public string UpdateDoctor(Doctor doctor)
        {
            try
            {
                var st = _context.Doctors.First(d => d.Id == doctor.Id);
                if (st != null)
                {

                    st.FirstName = doctor.FirstName;
                    st.LastName = doctor.LastName;
                    st.Email = doctor.Email;

                }
                return "Ok";

            }
            catch (Exception e)
            {

                return "Error";

            }
        }
    }
}
