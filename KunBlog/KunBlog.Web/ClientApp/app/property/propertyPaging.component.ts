import { Component, OnInit } from "@angular/core";
import { PagingParam } from "ClientApp/app/share/propertyPaging";
import { DataService } from "ClientApp/app/share/dataService";

@Component({
    selector: "the-paging",
    templateUrl: "propertyPaging.component.html",
    styleUrls: []
})

export class PropertyPaging implements OnInit {
    public propertyPaging: PagingParam = new PagingParam();

    constructor(private data: DataService) {
        this.propertyPaging = data.propertyPaging;
    }

    ngOnInit(): void {
        this.data.loadProperties()
            .subscribe(success => {
                if (success) {
                    this.propertyPaging = this.data.propertyPaging;
                }
            });
    }
}