import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms'
import { Department } from 'src/app/models/department';
import { DepartmentService } from 'src/app/services/department.service';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { Enterprise } from 'src/app/models/enterprise';
import { EnterpriseService } from 'src/app/services/enterprise.service';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})

export class CreateComponent implements OnInit {
  form: FormGroup;
  enterprises: Enterprise[] = [];

  constructor(private formBuilder: FormBuilder, private service: DepartmentService, private route: ActivatedRoute,
    private router: Router, private serviceEnter: EnterpriseService) {
    this.form = this.formBuilder.group({
      name: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(50)]],
      description: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(50)]],
      phone: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(15)]],
      enterpriseId: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(15)]]
    })
  }

  ngOnInit(): void {
    this.getEnterprises()
  }

  async save() {
    const department: Department = {
      name: this.form.get('name')?.value,
      description: this.form.get('description')?.value,
      phone: this.form.get('phone')?.value.toString(),
      enterpriseId: this.form.get('enterpriseId')?.value
    }
    
    await this.service.save(department).subscribe(data => {
      this.router.navigate(['/department']);
    })
  }

  getEnterprises() {    
    this.serviceEnter.getAll().subscribe(data => {
      this.enterprises = data;
    })
  }

}
