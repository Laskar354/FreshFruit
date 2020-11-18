using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFruit.Model
{
    interface BucketEventListener
    {
        void onsucceed(string message);
        void onvailed(string message);
    }
}
