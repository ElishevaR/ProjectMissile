using api_models;

namespace api_service
{
    public class TodoService
    {


        public TodoService()
        {

        }
        public IEnumerable<Racet> GetData()
        {
            return DB.data;
        }

        public IEnumerable<Racet> GetData(string city)
        {
            return DB.data.Where(t => t.location.city==city).ToList();
        }
        public IEnumerable<string> GetCity()
        {
           return  DB.data.Select(t => t.location.city).ToList().Distinct();
        }
        public bool add(Racet racet)
        {
            DB.data.Add(racet);
            return true;
        }

    }
}
