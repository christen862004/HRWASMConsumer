using HRWASMConsumer.Models;
using System.Net.Http.Json;

namespace HRWASMConsumer.Services
{
    public class EmployeeService : IServices<Employee>
    {
        HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)//ip
        {
            _httpClient = httpClient;
            
        }
        public async Task Delete(int id)
        {
            await _httpClient.DeleteAsync($"/api/Employees/{id}");//http://localhost:63289/api/Employees/{id}
        }

        public async Task<List<Employee>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<List<Employee>>("/api/Employees");  
        }

        public async Task<Employee> GetByID(int id)
        {
           return await _httpClient.GetFromJsonAsync<Employee>($"/api/Employees/{id}");
        }

        public async Task Insert(Employee item)
        {
            HttpResponseMessage respon= 
                await _httpClient.PostAsJsonAsync<Employee>("/api/Employees", item);
            
        }

        public async Task Update(int id, Employee item)
        {
            await _httpClient.PutAsJsonAsync<Employee>($"/api/Employees/{id}", item);
        }
    }
}
