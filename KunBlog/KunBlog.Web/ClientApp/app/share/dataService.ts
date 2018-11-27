import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";
import { Property } from "./property";
import { SearchParam } from "ClientApp/app/share/SearchParam";
import { PagingParam } from "ClientApp/app/share/propertyPaging";

@Injectable()
export class DataService {
    public properties: Property[] = [];
    public searchParam: SearchParam;
    public propertyPaging: PagingParam;

    constructor(private http: HttpClient) {
        this.searchParam = new SearchParam();
        this.propertyPaging = new PagingParam();
    }

    loadProperties(): Observable<boolean> {
        return this.http.get("http://localhost:57315/api/property")
            .pipe(
            map((data: any[]) => {
                this.properties = data;
                if (this.properties) {
                    let numberOfPage = (data.length - data.length % this.propertyPaging.recordPerPage) / this.propertyPaging.recordPerPage + 1;
                    alert(numberOfPage);
                    this.propertyPaging.activePage = 1;
                    this.propertyPaging.numberOfPage = Array(numberOfPage).fill(0).map((x, i) => i + 1);
                }
                else {
                    this.propertyPaging.activePage = 1;
                    this.propertyPaging.numberOfPage = [1];
                }
                return true;
            }));
    }
}