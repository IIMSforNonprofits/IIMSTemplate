import React, { Fragment } from 'react';
import { DetailView } from './detail-view.jsx';

export class Inventory extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            showDetailModal: false,
            displayData: [],
        };
        this.setState = this.setState.bind(this);
        this.fetchData = this.fetchData.bind(this);
        this.setData = this.setData.bind(this);
    }

    showModal = (e) => {
        this.setState({ showDetailModal: true })
    }

    hideModal = () => {
        this.setState({ showDetailModal: false })
    }

    // FORM SUBMISSION METHOD
    handleSubmit = (event) => {
        event.preventDefault();
        let newInvItem = { 
            donorID: event.target.donor_id.value, 
            sku: event.target.sku.value, 
            name: event.target.name.value,
            description: event.target.description.value 
        }
        event.target.donor_id.value = '';
        event.target.sku.value = '';
        event.target.name.value = '';
        event.target.description.value = '';
        fetch("http://localhost:9456/api/inventory", {
            method: "POST",
            mode: "cors",
            cache: "no-cache",
            credentials: "same-origin",
            headers: {
                "Content-Type": "application/json",
            },
            redirect: "follow",
            referrer: "no-referrer",
            body: JSON.stringify(newInvItem)
        }).then(response => response.json())
        .then(() => this.fetchData())
        .then(() => this.hideModal());
    }

    fetchData = () => {
        fetch("http://localhost:9456/api/inventory", {
            method: "GET",
            mode: "cors",
            cache: "no-cache",
            credentials: "same-origin",
            headers: {
                "Content-Type": "application/json",
            },
            redirect: "follow",
            referrer: "no-referrer",
        })
        .then(response => response.json())
        .then(data => {
            return this.setData(data);
        })
    }

    setData = (data) => {
        this.setState({displayData: data});
    }

    componentDidMount(){
        this.fetchData();
    }

    // =======================================
    // Methods 
    // componentDidMount() - async call to db for paginated inventory list. Proof of life is full list. 
    // =======================================
    render() {
        // this.fetchData();
        return (
            <div className="inventory">
                <h2>Inventory</h2>
                <ul className="invNav">
                    <li>ID</li>
                    <li>Name</li>
                    <li>Short Description</li>
                    <li>SKU</li>
                </ul>
                <div className="invList">
                    { this.state.displayData.map((item, i) => {
                        return (
                            <ul key={i} className="invListItem">
                                <li>{ item.ID }</li>
                                <li>{ item.Name }</li>
                                <li>{ item.Description }</li>
                                <li>{ item.Sku }</li>
                            </ul>
                        )
                    }) }
                    <button onClick={this.showModal}>Add Product</button>
                </div>

                <DetailView show={this.state.showDetailModal} handleClose={this.hideModal}>
                    <p>Enter a new inventory product</p>
                    <form className="newItemForm" onSubmit={this.handleSubmit}>
                        <label>
                            Donor ID:
                            <input type="number" name="donor_id" required />
                        </label>
                        <br></br>
                        <label>
                            SKU:
                            <input type="text" name="sku" required />
                        </label>
                        <br></br>
                        <label>
                            Name:
                            <input type="text" name="name"  required />
                        </label>
                        <br></br>
                        <label>
                            Description:
                            <input type="textarea" name="description" required />
                        </label>
                        <br></br>
                        <input type="submit" value="Submit New Item" />
                    </form>
                </DetailView>
            </div>
            // Render as a table with clickable table row 
            // ForEach to render the object into the table. 
        );
    }
}