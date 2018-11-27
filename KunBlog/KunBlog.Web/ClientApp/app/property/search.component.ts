import { Component } from "@angular/core";
import { SearchParam } from "../share/SearchParam";

@Component({
    selector: "the-search",
    templateUrl: "./search.component.html",
    styleUrls: []
})

export class SearchComponent {
    public searchParam: SearchParam;
    public title: string = "search your home";
    constructor() {
        this.searchParam = new SearchParam();
    }
}