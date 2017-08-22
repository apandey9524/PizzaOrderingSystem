namespace PizzaOrder
{
    public class Address
    {
        public string FlatOrBlockNumber { get; private set; }
        public string LocalityOrStreet { get; private set; }
        public string City { get; private set; }
        public string State{ get; private set; }
        
        public void SetAddress(string flatNumber,string locality,string city,string state)
        {
            FlatOrBlockNumber = flatNumber;
            LocalityOrStreet = locality;
            City = city;
            State = state;
        }

        public string GetCompleteAddress()
        {
            return FlatOrBlockNumber + '\n' + LocalityOrStreet + '\n' + City + '\n' + State;
        }
    }
}