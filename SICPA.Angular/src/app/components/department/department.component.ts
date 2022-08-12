import { Component, OnInit } from '@angular/core';
import { Department } from 'src/app/models/department';
import { DepartmentService } from 'src/app/services/department.service';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';

@Component({
  selector: 'app-department',
  templateUrl: './department.component.html',
  styleUrls: ['./department.component.css']
})
export class DepartmentComponent implements OnInit {
  departments: Department[] = [];

  constructor(private service: DepartmentService, private route: ActivatedRoute,
    private router: Router) {
  }

  ngOnInit(): void {
    const that = this;
    this.getAll()
  }

  getAll() {    
    this.service.getAll().subscribe(data => {
      console.log(data)
      this.departments = data;
    })
  }

  delete(id?: number) {
  this.service.delete(id?.toString()).subscribe(data => {
      this.getAll()
    })
  }

}