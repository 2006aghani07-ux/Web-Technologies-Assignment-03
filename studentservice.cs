using MongoDB.Driver;
using StudentRecordManager.Models;

namespace StudentRecordManager.Services
{
    public class StudentService
    {
        private readonly IMongoCollection<Student> _students;

        public StudentService(IConfiguration config)
        {
            var client = new MongoClient(
                config["StudentDatabase:ConnectionString"]);

            var db = client.GetDatabase(
                config["StudentDatabase:DatabaseName"]);

            _students = db.GetCollection<Student>(
                config["StudentDatabase:StudentsCollectionName"]);
        }

        public async Task<List<Student>> Get() =>
            await _students.Find(_ => true).ToListAsync();

        public async Task<Student?> Get(string id) =>
            await _students.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task Create(Student student) =>
            await _students.InsertOneAsync(student);

        public async Task Update(string id, Student student) =>
            await _students.ReplaceOneAsync(x => x.Id == id, student);

        public async Task Delete(string id) =>
            await _students.DeleteOneAsync(x => x.Id == id);
        }
        }
        


