using System;

namespace guest_app
{
    public class Visit_node
    {
        public Visit_node()
        {
            id = -1;
            room_cost = additional_cost = customer_id = 0;
            room_type = doc_type = additional_type = violations = comment = "";
            coming = departure = Convert.ToString(DateTime.Now);
        }

        public bool equals(Visit_node item)
        {
            return
                (id == item.id &&
                customer_id == item.customer_id &&
                room_type == item.room_type &&
                doc_type == item.doc_type &&
                room_cost == item.room_cost &&
                additional_cost == item.additional_cost &&
                additional_type == item.additional_type &&
                violations == item.violations &&
                coming == item.coming &&
                departure == item.departure &&
                comment == item.comment);
        }

        public int id;
        public int customer_id;
        public string room_type;
        public string doc_type;
        public int room_cost;
        public int additional_cost;
        public string additional_type;
        public string violations;
        public string coming;
        public string departure;
        public string comment;

    }
}
