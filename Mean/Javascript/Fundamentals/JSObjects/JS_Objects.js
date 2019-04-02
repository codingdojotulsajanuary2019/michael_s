let students = [
    {name: 'Remy', cohort: 'Jan'},
    {name: 'Genevieve', cohort: 'March'},
    {name: 'Chuck', cohort: 'Jan'},
    {name: 'Osmund', cohort: 'June'},
    {name: 'Nikki', cohort: 'June'},
    {name: 'Boris', cohort: 'June'}
];

var student;
for(student in students)
{
    console.log(`Name: ${students[student].name}, Cohort: ${students[student].cohort}`);
}

let users = {
    employees: [
        {'first_name':  'Miguel', 'last_name' : 'Jones'},
        {'first_name' : 'Ernie', 'last_name' : 'Bertson'},
        {'first_name' : 'Nora', 'last_name' : 'Lu'},
        {'first_name' : 'Sally', 'last_name' : 'Barkyoumb'}
    ],
    managers: [
       {'first_name' : 'Lillian', 'last_name' : 'Chambers'},
       {'first_name' : 'Gordon', 'last_name' : 'Poe'}
    ]
};

function PrintUserInfo(users)
{
    console.log("EMPLOYEES:");
    var employee;
    for(employee in users.employees)
    {
        var employeeNum = parseInt(employee, 10);
        var nameLength = users.employees[employee].last_name.length + users.employees[employee].first_name.length;
        console.log(`${employeeNum +1} - ${users.employees[employee].last_name}, ${users.employees[employee].first_name} - ${nameLength} `);
    }
    console.log("MANAGERS:");
    var manager;
    for(manager in users.managers)
    {
        var managernum = parseInt(manager, 10);
        var mnameLength = users.managers[manager].last_name.length + users.managers[manager].first_name.length;
        console.log(`${managernum +1} - ${users.managers[manager].last_name}, ${users.managers[manager].first_name} - ${mnameLength} `);

    }
}

PrintUserInfo(users);
