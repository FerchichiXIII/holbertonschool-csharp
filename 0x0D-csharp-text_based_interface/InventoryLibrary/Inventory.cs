using System;

namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        public string UserId { get; set; }
        public string ItemId { get; set; }
        private int _quantity = 1;

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value >= 0)
                    _quantity = value;
                else
                    throw new ArgumentOutOfRangeException("Quantity cannot be less than 0.");
            }
        }

        public Inventory(string userId, string itemId)
        {
            UserId = userId;
            ItemId = itemId;
        }
    }
}
