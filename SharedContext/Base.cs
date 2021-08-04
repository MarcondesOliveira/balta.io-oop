using System;
using Balta.NotificationContext;

namespace Balta.SharedContext {
    public abstract class Base : Notifiable {
        public Base(){
            id = Guid.NewGuid();
        }
        public Guid id { get; set; }
    }
}