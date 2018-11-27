import { Component } from "@angular/core";
import { DataService } from "../share/dataService";
import { OnInit } from "@angular/core";
import { Property } from "../share/property";

@Component({
    selector: "property-list",
    templateUrl: "propertyList.component.html",
    styleUrls: []
})

export class PropertyList implements OnInit {
    constructor(private data: DataService) {
        this.properties = data.properties;
    }

    public properties: Property[] = []

    ngOnInit(): void {
        this.data.loadProperties()
            .subscribe(success => {
                if (success) {
                    this.properties = this.data.properties;
                }
            });
    }
}