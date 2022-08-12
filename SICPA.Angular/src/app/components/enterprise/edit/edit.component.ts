import { Component, OnInit, OnDestroy } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms'
import { Enterprise } from 'src/app/models/enterprise';
import { EnterpriseService } from 'src/app/services/enterprise.service';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})

export class EditComponent implements OnInit, OnDestroy {
  form: FormGroup;
  id: number = 0;
  private sub: any;
  
  constructor(private formBuilder: FormBuilder, private service: EnterpriseService, private route: ActivatedRoute,
    private router: Router) {
    this.form = this.formBuilder.group({
      name: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(50)]],
      address: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(50)]],
      phone: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(15)]]
    })
    //this.enterprise = {};
  }

  ngOnInit(): void {
    this.sub = this.route.params.subscribe(params => {
      this.id = +params['id'];
      const result = this.service.getById(this.id).subscribe(data => {
        //this.enterprise = data;
        console.log(data)
        this.form.setValue({name: data.name, address: data.address, phone: data.phone})
      })
   });
  }

  ngOnDestroy() {
    this.sub.unsubscribe();
  }

  update() {
    const enterprise: Enterprise = {
      id: this.id,
      name: this.form.get('name')?.value,
      address: this.form.get('address')?.value,
      phone: this.form.get('phone')?.value.toString()
    }

    const result = this.service.update(enterprise).subscribe(data => {
      this.router.navigate(['/enterprise']);
    })
  }

}
