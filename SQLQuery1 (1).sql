﻿public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Class { get; set; }
}
public class StudentDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;");
    }
}public partial class Form1 : Form
{
    private readonly StudentDbContext _context;

    public Form1()
    {
        InitializeComponent();
        _context = new StudentDbContext();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        var student = new Student
        {
            Name = txtName.Text,
            Age = int.Parse(txtAge.Text),
            Class = txtClass.Text
        };

        _context.Students.Add(student);
        _context.SaveChanges();

        UpdateDataGrid();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        UpdateDataGrid();
    }

    private void UpdateDataGrid()
    {
        dataGridView1.DataSource = _context.Students.ToList();
    }
}