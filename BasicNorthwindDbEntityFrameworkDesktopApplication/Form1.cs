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

            //a�a��daki kodu try i�inde yazmazsak ilk de�eri dolduramad���ndan invalidcast hatas� verir.SelectedValue yerine indexi se�ip 1 eklersek de sorunu ��zeriz.
            //yane try olmadan �u kodu da yazabiliriz.
            //dgwProducts.DataSource = _productDal.GetByCategoryId(Convert.ToInt32(cbxCategoryName.SelectedIndex+1));

            try
            {
                dgwProducts.DataSource = _productDal.GetByCategoryId(Convert.ToInt32(cbxCategoryName.SelectedValue));


            }
            catch
            {
                //catch bo� b�rak�l�r.hatan�n bilindi�i varsay�l�yor.
                
            }

        }

        private void tbxSerachProductName_TextChanged(object sender, EventArgs e)
        {
            //burada tbxSearch i�eri�i string.IsNullOrEmpty metodu ile kontrol ettirilebilir.

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