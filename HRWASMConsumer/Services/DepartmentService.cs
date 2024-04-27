﻿using HRWASMConsumer.Models;
using System.Net.Http.Json;

namespace HRWASMConsumer.Services
{
    public class DepartmentService : IServices<Department>
    {
        private readonly HttpClient httpClient;

        public DepartmentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Department>> GetAll()
        {
           return await httpClient.GetFromJsonAsync<List<Department>>("/api/Department");
        }

        public Task<Department> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(Department item)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Department item)
        {
            throw new NotImplementedException();
        }
    }
}
