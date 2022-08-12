import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Department } from '../models/department';

@Injectable({
  providedIn: 'root'
})

export class DepartmentService {
  baseUrl = environment.baseUrl;
  apiUrl = 'api/Department'
  constructor(private http: HttpClient) { }

  getById(id: number): Observable<Department>
  {
    return this.http.get<Department>(this.baseUrl + this.apiUrl + '/' + id)
  }

  getAll(): Observable<Department[]>
  {
    return this.http.get<Department[]>(this.baseUrl + this.apiUrl)
  }

  save(department: Department): Observable<Department>
  {
    return this.http.post<Department>(this.baseUrl + this.apiUrl, department)
  }

  update(department: Department): Observable<Department>
  {
    return this.http.put<Department>(this.baseUrl + this.apiUrl, department)
  }

  delete(id?: string): Observable<any>
  {
    return this.http.delete<any>(this.baseUrl + this.apiUrl + '/' + id)
  }

}
