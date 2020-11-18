using FreshFruit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreshFruit.Controller
{
    class BucketController
    {
        private Bucket bucket;
        private BucketEventListener eventListener;

        public BucketController(Bucket bucket, BucketEventListener eventListener)
        {
            this.bucket = bucket;
            this.eventListener = eventListener;
        }

        public void addFruit(Fruit fruit)
        {
            if(bucketIsOverload())
            {
                eventListener.onvailed("Ops, keranjang penuh");
            }
            else
            {
                this.bucket.insert(fruit);
                eventListener.onsucceed("Yeyy!!, berhasil ditambhkan");
            }
        }

        public bool bucketIsOverload()
        {
            return bucket.countItems() >= bucket.getCapacity();
        }

        public void removeFruit(Fruit fruit)
        {
            for(int itemPosition = 0; itemPosition < bucket.countItems(); itemPosition++)
            {
                if(bucket.findAll().ElementAt(itemPosition).getName() == fruit.getName())
                {
                    bucket.remove(itemPosition);
                    eventListener.onsucceed("Yeyy!!, berhasil dihapus");
                }
            }
        }
        public List<Fruit> findAll()
        {
            return this.bucket.findAll();
        }
    }
}
