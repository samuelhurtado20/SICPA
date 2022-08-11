import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms'
import { Enterprise } from 'src/app/models/enterprise';
import { EnterpriseService } from 'src/app/services/enterprise.service';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {
  form: FormGroup;

  constructor(private formBuilder: FormBuilder, private service: EnterpriseService) { 
    this.form = this.formBuilder.group({
      id: 0,
      name: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(50)]],
      address: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(50)]],
      phone: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(15)]]
    })
  }

  ngOnInit(): void {
  }

  save(): void {
    const enterprise: Enterprise = {
      name: this.form.get('name')?.value,
      address: this.form.get('address')?.value,
      phone: this.form.get('phone')?.value
    }
    
    this.service.save(enterprise);
  }

}
