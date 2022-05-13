using BasicNorthwindDbEntityFrameworkDesktopApplication.DataAccess.Concrete;

namespace BasicNorthwindDbEntityFrameworkDesktopApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();
        CategoryDal _categoryDal = new CategoryDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategories();
        }

        private void ListProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }
        private void ListCategories()
        {
            cbxCategoryName.DataSource = _categoryDal.GetAll();
            cbxCategoryName.DisplayMember = "CategoryName";
            cbxCategoryName.ValueMember = "CategoryId";
        }

        private void cbxCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {

            //aþaðýdaki kodu try içinde yazmazsak ilk deðeri dolduramadýðýndan invalidcast hatasý verir.SelectedValue yerine indexi seçip 1 eklersek de sorunu çözeriz.
            //yane try olmadan þu kodu da yazabiliriz.
            //dgwProducts.DataSource = _productDal.GetByCategoryId(Convert.ToInt32(cbxCategoryName.SelectedIndex+1));

            try
            {
                dgwProducts.DataSource = _productDal.GetByCategoryId(Convert.ToInt32(cbxCategoryName.SelectedValue));


            }
            catch
            {
                //catch boþ býrakýlýr.hatanýn bilindiði varsayýlýyor.
                
            }

        }

        private void tbxSerachProductName_TextChanged(object sender, EventArgs e)
        {
            //burada tbxSearch içeriði string.IsNullOrEmpty metodu ile kontrol ettirilebilir.

            dgwProducts.DataSource = _productDal.SearchByProductName(tbxSerachProductName.Text);

        }
        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListAllProducts_Click(object sender, EventArgs e)
        {
            ListProducts();
        }

        
    }
}