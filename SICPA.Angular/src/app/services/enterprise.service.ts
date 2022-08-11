import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Enterprise } from '../models/enterprise';

@Injectable({
  providedIn: 'root'
})
export class EnterpriseService {
  baseUrl = ''
  apiUrl = ''
  constructor(private http: HttpClient) { }

  save(enterprise: Enterprise): Observable<Enterprise>{
    return this.http.post<Enterprise>(this.baseUrl + this.apiUrl, enterprise)
  }

}
