using Softclub.Model;
using Softclub.Service;
CourseService courseService = new CourseService();
DepartmentService departmentService = new DepartmentService();
EducationCenterService educationCenterService = new EducationCenterService();
EmployeeService employeeService = new EmployeeService();
GroupService groupService = new GroupService();
while (true)
{
    Console.WriteLine("Comand: course, department, educationcenter, employee, group, exit");
    Console.Write("Введите команду : ");
    string comand = Console.ReadLine();
    if (comand.ToLower().Trim() == "course")
    {
        while (true)
        {
            Console.WriteLine("Press 1 GetAll course");
            Console.WriteLine("Press 2 GetById course");
            Console.WriteLine("Press 3 Add course");
            Console.WriteLine("Press 4 Update course");
            Console.WriteLine("Press 5 Remove course");
            Console.WriteLine("Press 6 exit");
            int pres = Convert.ToInt32(Console.ReadLine());
            if (pres == 1)
            {
                var cours = await courseService.GetAll();
                foreach (var i in cours)
                {
                    var group =  groupService.GetAll().Result.Where(x => x.CourseId == i.Id).ToList();
                    Console.WriteLine($"Id курса {i.Id}");
                    Console.WriteLine($"Имя курса {i.CourseName}");
                    Console.Write($"Все группи от {i.CourseName} : ");
                    if (group.Count == 0) Console.WriteLine("пока група не добавлено");
                    else foreach (var m in group) Console.Write($" {m.GroupName} ,");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else if (pres == 2)
            {
                Console.Write("Введите id курса : ");
                int id = Convert.ToInt32(Console.ReadLine());
                var response = await courseService.GetById(id);
                if (response.Data == null) Console.WriteLine(response.Message);
                else
                {
                    Console.WriteLine(response.Data.CourseName);
                    var group = groupService.GetAll().Result.Where(x => x.CourseId == response.Data.Id).ToList();
                    Console.Write($"Все группи от {response.Data.CourseName} : ");
                    if (group.Count == 0) Console.WriteLine("пока група не добавлено ");
                    else foreach (var m in group) Console.Write($" {m.GroupName} ,");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else if (pres == 3)
            {
                Course course = new Course();
                Console.Write("Введите имя курса : ");
                course.CourseName = Console.ReadLine();
                var responce =await courseService.Add(course);
                Console.WriteLine(responce.Message);
                Console.WriteLine();
            }
            else if (pres == 4)
            {
                Course course = new Course();
                Console.Write("Введите id курса : ");
                course.Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите имя курса : ");
                course.CourseName = Console.ReadLine();
                var responce =await courseService.Update(course);
                Console.WriteLine(responce.Message);
                Console.WriteLine();
            }
            else if (pres == 5)
            {
                Console.Write("Введите id курса : ");
                int id = Convert.ToInt32(Console.ReadLine());
                var responce =await courseService.Remove(id);
                Console.WriteLine(responce.Message);
                Console.WriteLine();
            }
            else if (pres == 6) break;
            else Console.WriteLine("Неверный команда");
        }
    }
    else if (comand.ToLower().Trim() == "group")
    {
        while (true)
        {
            Console.WriteLine("Press 1 GetAll group");
            Console.WriteLine("Press 2 GetById group");
            Console.WriteLine("Press 3 Add group");
            Console.WriteLine("Press 4 Update group");
            Console.WriteLine("Press 5 Remove group");
            Console.WriteLine("Press 6 exit");
            int pres = Convert.ToInt32(Console.ReadLine());
            if (pres == 1)
            {
                var group =await groupService.GetAll();
                foreach (var i in group)
                {
                    var course = courseService.GetAll().Result.FirstOrDefault(x => x.Id == i.CourseId);
                    Console.WriteLine($"Id група {i.Id}");
                    Console.WriteLine($"Имя група {i.GroupName}");
                    if (course != null) Console.Write($"Это группа от {course.CourseName} курса : ");
                    else Console.WriteLine("Группа не находит в курса");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else if (pres == 2)
            {
                Console.Write("Введите id группа : ");
                int id = Convert.ToInt32(Console.ReadLine());
                var response =await groupService.GetById(id);
                if (response.Data == null) Console.WriteLine(response.Message);
                else
                {
                    Console.WriteLine(response.Data.GroupName);
                    var course = courseService.GetAll().Result.FirstOrDefault(x => x.Id == response.Data.Id);
                    Console.Write($"Это группа от {course.CourseName} курса : ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else if (pres == 3)
            {
                Group group = new Group();
                Console.Write("Введите имя группа  : ");
                group.GroupName = Console.ReadLine();
                Console.Write("Введите id курса  : ");
                group.CourseId = Convert.ToInt32(Console.ReadLine());
                var responce =await groupService.Add(group);
                Console.WriteLine(responce.Message);
                Console.WriteLine();
            }
            else if (pres == 4)
            {
                Group group = new Group();
                Console.Write("Введите id группа : ");
                group.Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите имя группа : ");
                group.GroupName = Console.ReadLine();
                Console.Write("Введите id курса  : ");
                group.CourseId = Convert.ToInt32(Console.ReadLine());
                var responce =await groupService.Update(group);
                Console.WriteLine(responce.Message);
                Console.WriteLine();
            }
            else if (pres == 5)
            {
                Console.Write("Введите id курса : ");
                int id = Convert.ToInt32(Console.ReadLine());
                var responce =await courseService.Remove(id);
                Console.WriteLine(responce.Message);
                Console.WriteLine();
            }
            else if (pres == 6) break;
            else Console.WriteLine("Неверный команда");
        }
    }
    else if (comand.ToLower().Trim() == "educationcenter")
    {
        while (true)
        {
            Console.WriteLine("Press 1 GetAll educationcenter");
            Console.WriteLine("Press 2 GetById educationcenter");
            Console.WriteLine("Press 3 Add educationcenter");
            Console.WriteLine("Press 4 Update educationcenter");
            Console.WriteLine("Press 5 Remove educationcenter");
            Console.WriteLine("Press 6 exit");
            int pres = Convert.ToInt32(Console.ReadLine());
            if (pres == 1)
            {
                var educationCenters =await educationCenterService.GetAll();
                foreach (var i in educationCenters)
                {
                    var education = departmentService.GetAll().Result.Where(x => x.EducationCenterId == i.Id).ToList();
                    Console.WriteLine($"Id образовательный центр {i.Id}");
                    Console.WriteLine($"Имя образовательный центр {i.Name}");
                    Console.Write($"Все отделы образовательный центр {i.Name} : ");
                    if (education.Count == 0) Console.WriteLine("Пока у этого образовательный центр нет отдел ");
                    else foreach (var m in education) Console.Write($" {m.Name} ,");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else if (pres == 2)
            {
                Console.Write("Введите id образовательный центр : ");
                int id = Convert.ToInt32(Console.ReadLine());
                var response =await educationCenterService.GetById(id);
                if (response.Data == null) Console.WriteLine(response.Message);
                else
                {
                    Console.WriteLine("Образовательный центр " + response.Data.Name);
                    var education = departmentService.GetAll().Result.Where(x => x.EducationCenterId == response.Data.Id).ToList();
                    Console.Write($"Все отделы образовательный центр : ");
                    if (education.Count == 0) Console.WriteLine("Пока у этого образовательный центр нет отдел ");
                    else foreach (var m in education) Console.Write($" {m.Name} ,");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else if (pres == 3)
            {
                EducationCenter educationCenter = new EducationCenter();
                Console.Write("Введите имя образовательный центр  : ");
                educationCenter.Name = Console.ReadLine();
                var responce =await educationCenterService.Add(educationCenter);
                Console.WriteLine(responce.Message);
                Console.WriteLine();
            }
            else if (pres == 4)
            {
                EducationCenter educationCenter = new EducationCenter();
                Console.Write("Введите id образовательный центр : ");
                educationCenter.Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите имя образовательный центр : ");
                educationCenter.Name = Console.ReadLine();
                var responce =await educationCenterService.Update(educationCenter);
                Console.WriteLine(responce.Message);
                Console.WriteLine();
            }
            else if (pres == 5)
            {
                Console.Write("Введите id образовательный центр : ");
                int id = Convert.ToInt32(Console.ReadLine());
                var responce =await educationCenterService.Remove(id);
                Console.WriteLine(responce.Message);
                Console.WriteLine();
            }
            else if (pres == 6) break;
            else Console.WriteLine("Неверный команда");
        }
    }
    else if (comand.ToLower().Trim() == "department")
    {
        while (true)
        {
            Console.WriteLine("Press 1 GetAll department");
            Console.WriteLine("Press 2 GetById department");
            Console.WriteLine("Press 3 Add department");
            Console.WriteLine("Press 4 Update department");
            Console.WriteLine("Press 5 Remove department");
            Console.WriteLine("Press 6 exit");
            int pres = Convert.ToInt32(Console.ReadLine());
            if (pres == 1)
            {
                var department =await departmentService.GetAll();
                foreach (var i in department)
                {
                    var education = educationCenterService.GetAll().Result.FirstOrDefault(x => x.Id == i.EducationCenterId);
                    var employees = employeeService.GetAll().Result.Where(x => x.DepartmentId == i.Id).ToList();
                    Console.WriteLine($"Id отдел {i.Id}");
                    Console.WriteLine($"Имя отдел {i.Name}");
                    if (education != null) Console.Write($"Отделы находиться на {education.Name} образовательный центр  : ");
                    else Console.WriteLine("Отдел не находится на образовательный центр");
                    if (employees.Count == 0) Console.WriteLine("Пока у этого отдела нет employee");
                    else foreach (var m in employees) Console.WriteLine(m.GetFullName());
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else if (pres == 2)
            {
                Console.Write("Введите id отдел : ");
                int id = Convert.ToInt32(Console.ReadLine());
                var response =await departmentService.GetById(id);
                if (response.Data == null) Console.WriteLine(response.Message);
                else
                {
                    Console.WriteLine("Oтдел " + response.Data.Name);
                    var education = educationCenterService.GetAll().Result.FirstOrDefault(x => x.Id == response.Data.Id);
                    var employees = employeeService.GetAll().Result.Where(x => x.DepartmentId == response.Data.Id).ToList();
                    Console.Write($"Все отделы образовательный центр : ");
                    if (education == null) Console.WriteLine("Пока у этого отдел нет образовательный центр");
                    else Console.Write($"Отделы находиться на {education.Name} образовательный центр  : ");
                    if (employees.Count == 0) Console.WriteLine("Пока у этого отдела нет employee");
                    else foreach (var m in employees) Console.WriteLine(m.GetFullName());
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else if (pres == 3)
            {
                Department department = new Department();
                Console.Write("Введите имя  отдел  : ");
                department.Name = Console.ReadLine();
                Console.Write("Введите id образовательный центр : ");
                department.EducationCenterId = Convert.ToInt32(Console.ReadLine());
                var responce =await departmentService.Add(department);
                Console.WriteLine(responce.Message);
                Console.WriteLine();
            }
            else if (pres == 4)
            {
                Department department = new Department();
                Console.Write("Введите id отдел : ");
                department.Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите имя отдел : ");
                department.Name = Console.ReadLine();
                var responce =await departmentService.Update(department);
                Console.WriteLine(responce.Message);
                Console.WriteLine();
            }
            else if (pres == 5)
            {
                Console.Write("Введите id отдел : ");
                int id = Convert.ToInt32(Console.ReadLine());
                var responce =await departmentService.Remove(id);
                Console.WriteLine(responce.Message);
                Console.WriteLine();
            }
            else if (pres == 6) break;
            else Console.WriteLine("Неверный команда");
        }
    }
    else if (comand.ToLower().Trim() == "employee")
    {
        while (true)
        {
            Console.WriteLine("Press 1 GetAll employee");
            Console.WriteLine("Press 2 GetById employee");
            Console.WriteLine("Press 3 Add employee");
            Console.WriteLine("Press 4 Update employee");
            Console.WriteLine("Press 5 Remove employee");
            Console.WriteLine("Press 6 exit");
            int pres = Convert.ToInt32(Console.ReadLine());
            if (pres == 1)
            {
                var employe =await employeeService.GetAll();
                foreach (var i in employe)
                {
                    var employee = departmentService.GetAll().Result.FirstOrDefault(x => x.Id == i.DepartmentId);
                    Console.WriteLine(i.GetFullInfo());
                    if (employee != null) Console.Write($"Employe находиться на {employee.Name} Отдел  : ");
                    else Console.WriteLine("Пока employe не находится на отдел");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else if (pres == 2)
            {
                Console.Write("Введите id employee : ");
                int id = Convert.ToInt32(Console.ReadLine());
                var response = await employeeService.GetById(id);
                if (response.Data == null) Console.WriteLine(response.Message);
                else
                {
                    Console.WriteLine(response.Data.GetFullInfo());
                    var employee = departmentService.GetAll().Result.FirstOrDefault(x => x.Id == response.Data.DepartmentId);
                    if (employee == null) Console.WriteLine("Пока это employe не находится на отдел");
                    else Console.Write($"Employee находиться на {employee.Name} отдел  : ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else if (pres == 3)
            {
                Employee employee = new Employee();
                Console.Write("Введите имя  : ");
                employee.FirstName = Console.ReadLine();
                Console.Write("Введите фамилия  : ");
                employee.LastName = Console.ReadLine();
                Console.Write("Введите age  : ");
                employee.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите gender  pres [m-w] : ");
                employee.Gender = Convert.ToChar(Console.ReadLine());
                Console.Write("Введите adress: ");
                employee.Adress = Console.ReadLine();
                Console.Write("Введите Id отдел : ");
                employee.DepartmentId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите  position [junior,midle,senior] : ");
                employee.Position = Console.ReadLine();
                var responce = await employeeService.Add(employee);
                Console.WriteLine(responce.Message);
                Console.WriteLine();
            }
            else if (pres == 4)
            {
                Employee employee = new Employee();
                Console.Write("Введите id employee : ");
                employee.Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите имя  : ");
                employee.FirstName = Console.ReadLine();
                Console.Write("Введите фамилия  : ");
                employee.LastName = Console.ReadLine();
                Console.Write("Введите age  : ");
                employee.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите gender  pres [m-w] : ");
                employee.Gender = Convert.ToChar(Console.ReadLine());
                Console.Write("Введите adress: ");
                employee.Adress = Console.ReadLine();
                Console.Write("Введите Id отдел : ");
                employee.DepartmentId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите position [junior,midle,senior] : ");
                employee.Position = Console.ReadLine();
                var responce = await employeeService.Update(employee);
                Console.WriteLine(responce.Message);
                Console.WriteLine();
            }
            else if (pres == 5)
            {
                Console.Write("Введите id employee : ");
                int id = Convert.ToInt32(Console.ReadLine());
                var responce =await employeeService.Remove(id);
                Console.WriteLine(responce.Message);
                Console.WriteLine();
            }
            else if (pres == 6) break;
            else Console.WriteLine("Неверный команда");
        }
    }
    else Console.WriteLine("Неверный команда ");
}