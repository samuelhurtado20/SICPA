import { Component, OnInit, OnDestroy } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms'
import { Department } from 'src/app/models/department';
import { DepartmentService } from 'src/app/services/department.service';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { Enterprise } from 'src/app/models/enterprise';
import { EnterpriseService } from 'src/app/services/enterprise.service';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})

export class EditComponent implements OnInit, OnDestroy {
  formEdit: FormGroup;
  id: number = 0;
  private sub: any;
  enterprises: Enterprise[] = [];
  
  constructor(private formBuilder: FormBuilder, private service: DepartmentService, private route: ActivatedRoute,
    private router: Router, private serviceEnter: EnterpriseService) {
    this.formEdit = this.formBuilder.group({
      name: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(50)]],
      description: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(50)]],
      phone: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(15)]],
      enterpriseId: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(15)]]
    })
  }

  ngOnInit(): void {
    this.sub = this.route.params.subscribe(params => {
      this.id = +params['id'];
      this.service.getById(this.id).subscribe(data => {
        this.formEdit.setValue({name: data.name, description: data.description, phone: data.phone, enterpriseId: data.enterpriseId})
      })
   });
   this.getEnterprises()
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

  update() {
    const department: Department = {
      id: this.id,
      name: this.formEdit.get('name')?.value,
      description: this.formEdit.get('description')?.value,
      phone: this.formEdit.get('phone')?.value.toString(),
      enterpriseId: this.formEdit.get('enterpriseId')?.value
    }

    this.service.update(department).subscribe(data => {
      this.router.navigate(['/department']);
    })
  }

  getEnterprises() {    
    this.serviceEnter.getAll().subscribe(data => {
      this.enterprises = data;
    })
  }

}
