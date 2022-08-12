import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/employee';
import { EmployeeService } from 'src/app/services/employee.service';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
  employees: Employee[] = [];

  constructor(private service: EmployeeService, private route: ActivatedRoute,
    private router: Router) {
  }

  ngOnInit(): void {
    const that = this;
    this.getAll()
  }

  getAll() {    
    this.service.getAll().subscribe(data => {
      console.log(data)
      this.employees = data;
    })
  }

  delete(id?: number) {
  this.service.delete(id?.toString()).subscribe(data => {
      this.getAll()
    })
  }

}