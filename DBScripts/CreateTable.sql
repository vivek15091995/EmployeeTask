CREATE TABLE [Departments](
	[DepartmentId] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [Designations](
	[DesignationId] [int] IDENTITY(1,1) NOT NULL,
	[DesignationName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Designations_1] PRIMARY KEY CLUSTERED 
(
	[DesignationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [Employees](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[EmpTag] [varchar](50) NOT NULL,
	[Firstname] [varchar](50) NOT NULL,
	[Lastname] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[DepartmentId] [int] NOT NULL,
	[DOB] [date] NOT NULL,
	[DesignationId] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([DepartmentId])


ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Departments]


ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Designations] FOREIGN KEY([DesignationId])
REFERENCES [dbo].[Designations] ([DesignationId])


ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Designations]


--CREATE VIEW EmployeeListForView
--AS
--Select e.*,d1.DepartmentName ,d2.DesignationName,CONVERT(int,ROUND(DATEDIFF(hour,e.DOB,GETDATE())/8766.0,0)) as Age From Employees e
--Inner Join Departments d1 on d1.DepartmentId = e.DepartmentId
--Inner Join Designations d2 on d2.DesignationId = e.DesignationId


Insert into Departments values('Engineering');
Insert into Designations values('Software Engineer');
Insert into Departments values('Engineering');
Insert into Designations values('Software Engineer');

