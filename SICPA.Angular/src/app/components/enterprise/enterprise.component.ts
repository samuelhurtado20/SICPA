import { Component, OnInit } from '@angular/core';
import { Enterprise } from 'src/app/models/enterprise';
import { EnterpriseService } from 'src/app/services/enterprise.service';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';

@Component({
  selector: 'app-enterprise',
  templateUrl: './enterprise.component.html',
  styleUrls: ['./enterprise.component.css']
})
export class EnterpriseComponent implements OnInit {
  enterprises: Enterprise[] = [];

  constructor(private service: EnterpriseService, private route: ActivatedRoute,
    private router: Router) {
  }

  ngOnInit(): void {
    const that = this;
    this.getAll()
  }

  getAll() {    
    this.service.getAll().subscribe(data => {
      console.log(data)
      this.enterprises = data;
    })
  }

  delete(id?: number) {
    const result = this.service.delete(id?.toString()).subscribe(data => {
      this.getAll()
    })
  }

}
