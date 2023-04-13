namespace HelloYou
{
    public class Store
    {
        public int StoreId;
        public string StoreName;

        public Store()
        {
            
        }
        public Store(int storeId, string storeName)
        {
            this.StoreId = storeId;
            this.StoreName = storeName;
        }
    }
}