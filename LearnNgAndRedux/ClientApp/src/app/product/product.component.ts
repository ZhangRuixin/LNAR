import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  Products: Product[];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Product[]>(baseUrl + 'Demo/GetPrducts').subscribe(result => {
      this.Products = result;
    }, error => console.error(error));
  }

  ngOnInit() {
  }

}


interface Product {
  id: number,
  title: string,
  price: number,
  rating: number,
  desc: string,
  categories:string[]
}


