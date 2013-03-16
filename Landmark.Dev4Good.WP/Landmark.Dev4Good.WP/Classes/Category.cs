using System.ComponentModel;
using System.Data.Linq.Mapping;

namespace Landmark.Dev4Good.WP.Classes
{
    [Table]
    public class Category : INotifyPropertyChanged, INotifyPropertyChanging
    {
        // Define ID: private field, public property, and database column.
        private int _id;

        [Column(DbType = "INT NOT NULL IDENTITY", IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id
        {
            get { return _id; }
            set
            {
                NotifyPropertyChanging("Id");
                _id = value;
                NotifyPropertyChanged("Id");
            }
        }
        // Define ID: private field, public property, and database column.
        private string _title;
        [Column(CanBeNull = false)]
        public string Title
        {
            get { return _title; }
            set
            {
                NotifyPropertyChanging("Title");
                _title = value;
                NotifyPropertyChanged("Title");
            }
        }

        // Define category Description: private field, public property, and database column.
        private string _description;

        [Column]
        public string Description
        {
            get { return _description; }
            set
            {
                NotifyPropertyChanging("Description");
                _description = value;
                NotifyPropertyChanged("Description");
            }
        }
        private bool _isSpecial;
        [Column]
        public bool IsSpecial
        {
            get { return _isSpecial; }
            set
            {
                NotifyPropertyChanging("IsSpecial");
                _isSpecial = value;
                NotifyPropertyChanged("IsSpecial");
            }
        }

        //// Define the entity set for the collection side of the relationship.
        //private EntitySet<Product> _products;
        //[Association(Name = "FK_Product_Product", Storage = "_products", OtherKey = "_categoryId", ThisKey = "Id")]
        //public EntitySet<Product> Products
        //{
        //    get { return _products; }
        //    set { _products.Assign(value); }
        //}

        //// Define the entity set for the collection side of the relationship.
        //  public ObservableCollection<Product> LoadedProducts
        //{
        //    get { return   new ObservableCollection<Product>(Products); }
            
        //}
        private int _totalProducts;


        [Column]
        public int TotalProducts
        {
            get { return _totalProducts; }
            set
            {
                NotifyPropertyChanging("TotalProducts");
                _totalProducts = value;
                NotifyPropertyChanged("TotalProducts");
            }
        }
        private string _menuThumbnailImageUrl;
        [Column]
        public string MenuThumbnailImageUrl
        {
            get { return _menuThumbnailImageUrl; }
            set
            {
                NotifyPropertyChanging("MenuThumbnailImageUrl");
                _menuThumbnailImageUrl = value;
                NotifyPropertyChanged("MenuThumbnailImageUrl");
            }
        }
        private string _thumbnailImagePath;
        /// <summary>
        /// Gets or sets ThumbnailImage.
        /// </summary>
        [Column]
        public string ThumbnailImagePath
        {
            get
            {
                return _thumbnailImagePath;
            }
            set
            {
                NotifyPropertyChanging("ThumbnailImagePath");
                _thumbnailImagePath = value;
                NotifyPropertyChanged("ThumbnailImagePath");
            }
        }


        // Assign handlers for the add and remove operations, respectively.
        //public Category()
        //{
        //    _products = new EntitySet<Product>(
        //        this.attach_Product,
        //        this.detach_Product
        //        );
        //}

        //// Called during an add operation
        //private void attach_Product(Product product)
        //{
        //    NotifyPropertyChanging("Product");
        //    product.Category = this;
        //}

        //// Called during a remove operation
        //private void detach_Product(Product toDo)
        //{
        //    NotifyPropertyChanging("Product");
        //    toDo.Category = null;
        //}

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        // Used to notify that a property changed
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region INotifyPropertyChanging Members

        public event PropertyChangingEventHandler PropertyChanging;

        // Used to notify that a property is about to change
        private void NotifyPropertyChanging(string propertyName)
        {
            if (PropertyChanging != null)
            {
                PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
            }
        }

        #endregion
    }

}
