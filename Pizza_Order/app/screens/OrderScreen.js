import React, { useContext, useState } from 'react';
import {
  View, Text, Image, TouchableOpacity, StyleSheet, ScrollView
} from 'react-native';
import options from '../../assets/data/options.json';
import { CartContext } from '../context/CartContext';
import { MaterialIcons } from '@expo/vector-icons';
import { useNavigation } from '@react-navigation/native';

const OrderScreen = ({ route }) => {
  const navigation = useNavigation();
  const { product } = route.params;
  const productOptions = options.find(o => o.productId === product.id);

  const [selectedSize, setSelectedSize] = useState(productOptions.sizes[0]);
  const [addons, setAddons] = useState([]);
  const [quantity, setQuantity] = useState(1);
  const { addToCart } = useContext(CartContext);

  const toggleAddon = (addon) => {
    setAddons(prev =>
      prev.find(a => a.label === addon.label)
        ? prev.filter(a => a.label !== addon.label)
        : [...prev, addon]
    );
  };

  const total = (selectedSize.price + addons.reduce((sum, a) => sum + a.price, 0)) * quantity;

  const handleAdd = () => {
    addToCart({ product, selectedSize, addons, quantity, total });
    navigation.navigate('Basket');
  };

  return (
    <View style={styles.container}>
      <ScrollView contentContainerStyle={styles.scrollContainer}>
        <Image source={{ uri: product.image }} style={styles.image} />

        <Text style={styles.name}>{product.name}</Text>

        <Text style={styles.sectionTitle}>Select Size</Text>
        {productOptions.sizes.map(size => (
          <TouchableOpacity
            key={size.label}
            onPress={() => setSelectedSize(size)}
            style={[
              styles.optionItem,
              selectedSize.label === size.label && styles.optionSelected
            ]}
          >
            <Text>{size.label}</Text>
            <Text>${size.price.toFixed(2)}</Text>
          </TouchableOpacity>
        ))}

        <Text style={styles.sectionTitle}>Add-ons</Text>
        {productOptions.addons.map(addon => (
          <TouchableOpacity
            key={addon.label}
            onPress={() => toggleAddon(addon)}
            style={styles.addonItem}
          >
            <MaterialIcons
              name={addons.find(a => a.label === addon.label) ? 'check-box' : 'check-box-outline-blank'}
              size={24}
              color="green"
            />
            <Text style={{ marginLeft: 8 }}>{addon.label} - ${addon.price.toFixed(2)}</Text>
          </TouchableOpacity>
        ))}

        <View style={styles.quantityRow}>
          <TouchableOpacity onPress={() => setQuantity(Math.max(1, quantity - 1))} style={styles.qtyButton}>
            <Text style={styles.qtyText}>-</Text>
          </TouchableOpacity>
          <Text style={styles.qtyNumber}>{quantity}</Text>
          <TouchableOpacity onPress={() => setQuantity(quantity + 1)} style={styles.qtyButton}>
            <Text style={styles.qtyText}>+</Text>
          </TouchableOpacity>
        </View>
      </ScrollView>

      {/* Footer */}
      <View style={styles.footer}>
        <Text style={styles.totalText}>Total: ${total.toFixed(2)}</Text>
        <TouchableOpacity onPress={handleAdd} style={styles.addBtn}>
          <Text style={{ color: 'white', fontWeight: 'bold' }}>Add</Text>
        </TouchableOpacity>
      </View>
    </View>
  );
};

const styles = StyleSheet.create({
  container: { flex: 1, backgroundColor: '#fff' },
  scrollContainer: { padding: 16, paddingBottom: 120 },
  image: { width: '100%', height: 220, borderRadius: 12, marginBottom: 16 },
  name: { fontSize: 22, fontWeight: 'bold', marginBottom: 12 },
  sectionTitle: { fontSize: 16, fontWeight: '600', marginVertical: 10 },
  optionItem: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    padding: 12,
    borderWidth: 1,
    borderRadius: 10,
    marginVertical: 4,
    borderColor: '#ddd',
  },
  optionSelected: {
    backgroundColor: '#e0f7e9',
    borderColor: 'green',
  },
  addonItem: {
    flexDirection: 'row',
    alignItems: 'center',
    paddingVertical: 6,
  },
  quantityRow: {
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'center',
    marginVertical: 20,
  },
  qtyButton: {
    backgroundColor: '#eee',
    padding: 10,
    borderRadius: 8,
    marginHorizontal: 16,
  },
  qtyText: { fontSize: 20, fontWeight: 'bold' },
  qtyNumber: { fontSize: 20, fontWeight: '600' },
  footer: {
    position: 'absolute',
    bottom: 0,
    left: 0,
    right: 0,
    flexDirection: 'row',
    justifyContent: 'space-between',
    alignItems: 'center',
    backgroundColor: '#fff',
    padding: 16,
    borderTopWidth: 1,
    borderTopColor: '#eee',
  },
  totalText: { fontSize: 18, fontWeight: 'bold', color: 'green' },
  addBtn: {
    backgroundColor: 'green',
    paddingHorizontal: 24,
    paddingVertical: 10,
    borderRadius: 10,
  },
});

export default OrderScreen;