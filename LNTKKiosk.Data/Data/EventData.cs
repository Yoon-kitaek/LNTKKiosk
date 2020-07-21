using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class EventData : EntityData<Event>
    {
        public Event Get(int eventId)
        {
            LNTKEntities context = CreateContext();

            return context.Events.FirstOrDefault(a => a.EventId == eventId);
        }

        public void Delete(int eventId)
        {
            Event @event = Get(eventId);

            if (@event == null)
                return;

            Delete(@event);
        }

        public int GetMaxId()
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.Events
                        orderby x.EventId descending
                        select x.EventId;

            return query.FirstOrDefault();

        }
    }
}
