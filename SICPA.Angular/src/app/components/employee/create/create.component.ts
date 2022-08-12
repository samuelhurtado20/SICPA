import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms'
import { Employee } from 'src/app/models/employee';
import { EmployeeService } from 'src/app/services/employee.service';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})

export class CreateComponent implements OnInit {
  form: FormGroup;

  constructor(private formBuilder: FormBuilder, private service: EmployeeService, private route: ActivatedRoute,
    private router: Router) {
    this.form = this.formBuilder.group({
      name: ['', [Validators.required]],
      position: ['', [Validators.required]],
      age: ['', [Validators.required]],
      email: ['', [Validators.required]],
      surname: ['', [Validators.required]]
    })
  }

  ngOnInit(): void {
  }

  async save() {
    const employee: Employee = {
      name: this.form.get('name')?.value,
      position: this.form.get('position')?.value,
      age: this.form.get('age')?.value.toString(),
      email: this.form.get('email')?.value,
      surname: this.form.get('surname')?.value
    }
    
    await this.service.save(employee).subscribe(data => {
      this.router.navigate(['/employee']);
    })
  }

}
